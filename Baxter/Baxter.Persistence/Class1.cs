﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baxter.Persistence
{
    public sealed class Inclass : IDisposable
    {
        private static Inclass instance = null;
        private static readonly object padlock = new object();

        Inclass()
        {
            Connection = new SQLiteConnection("Data Source =:memory:; Version = 3; New = True; DateTimeFormat = Ticks");
            Connection.Open();
        }

        public static Inclass Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Inclass();
                    }
                    return instance;
                }
            }
        }

        public void Go()
        {
            
        }

        public SQLiteConnection Connection { get; set; }

        public void CreateTable()
        {
            string sql = "create table highscores (name varchar(20), score int)";

            SQLiteCommand command = new SQLiteCommand(sql, Connection);
            command.ExecuteNonQuery();

            sql = "insert into highscores (name, score) values ('Me', 9001)";

            command = new SQLiteCommand(sql, Connection);
            command.ExecuteNonQuery();

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
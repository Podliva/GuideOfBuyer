﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuideOfBuyer.Bll.Data
{
    public class TypeOfOwnership
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TypeOfOwnership()
        {
        }

        public TypeOfOwnership(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public TypeOfOwnership(string dataString)
        {
            if (dataString.IndexOf('|') == -1)
            {
                throw new Exception("Bad input data. Not found char '|'");
            }
            var mas = dataString.Split('|');
            Id = Convert.ToInt32(mas[0]);
            Name = mas[1];
        }

        public override string ToString()
        {
            return Name;
        }

        public string ToSaveString()
        {
            return string.Format("{0}|{1}", Id, Name);
        }
    }
}

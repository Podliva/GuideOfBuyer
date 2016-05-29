using System;

namespace GuideOfBuyer.Bll.Data
{
    public class Firm
    {
        public int Id { get; set; }
        /// <summary>
        /// Спецификация фимы
        /// </summary>
        public int SpecId { get; set; }
        /// <summary>
        /// Форма собственности
        /// </summary>
        public int TooId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phones { get; set; }

        public string TimeWork { get; set; }

        #region Calc fields

        public string SpecName { get; set; }
        public string TooName { get; set; }

        #endregion


        public Firm()
        {
        }

        public Firm(int id, int specId, int tooId, string name, string address, string phones, string timeWork)
        {
            Id = id;
            SpecId = specId;
            TooId = tooId;
            Name = name;
            Address = address;
            Phones = phones;
            TimeWork = timeWork;
        }

        public Firm(string dataString)
        {
            if (dataString.IndexOf('|') == -1)
            {
                throw new Exception("Bad input data. Not found char '|'");
            }
            var mas = dataString.Split('|');

            if (mas.Length < 7)
            {
                throw new Exception("Bad input data. Need 7 elements, but found " + mas.Length + " elements.");
            }

            Id = Convert.ToInt32(mas[0]);
            SpecId = Convert.ToInt32(mas[1]);
            TooId = Convert.ToInt32(mas[2]);
            Name = mas[3];
            Address = mas[4];
            Phones = mas[5];
            TimeWork = mas[6];
        }

        public string ToSaveString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", Id, SpecId, TooId, Name, Address, Phones, TimeWork);
        }
    }
}

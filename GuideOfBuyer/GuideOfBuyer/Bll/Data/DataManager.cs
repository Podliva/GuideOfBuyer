using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GuideOfBuyer.Bll.Data
{
    public static class DataManager
    {
        public const char UnitSeparator = (char) 31;

        #region TypeOfOwnerships

        private const string fileNameTypeOfOwnerships = "TypeOfOwnerships.txt";
        public static List<TypeOfOwnership> TypeOfOwnerships { get; private set; }

        public static bool LoadTypeOfOwnership()
        {
            var path = FileHelper.GetDataFilesPath() + fileNameTypeOfOwnerships;
            TypeOfOwnerships = new List<TypeOfOwnership>();
            if (!File.Exists(path))
            {
                return false;
            }

            var str = FileHelper.LoadFile(path, 1251);
            var lines = str.Replace("\r\n", "\r").Split('\r');
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                var obj = new TypeOfOwnership(line);
                TypeOfOwnerships.Add(obj);
            }
            return true;
        }

        public static bool SaveTypeOfOwnership()
        {
            var path = FileHelper.GetDataFilesPath() + fileNameTypeOfOwnerships;
            var sb = new StringBuilder();
            foreach (var typeOfOwnership in TypeOfOwnerships)
            {
                sb.AppendLine(typeOfOwnership.ToSaveString());
            }
            return string.IsNullOrEmpty(FileHelper.SaveFile(path, sb.ToString()));
        }

        public static int TooGetNewId()
        {
            if (TypeOfOwnerships == null || TypeOfOwnerships.Count == 0)
            {
                return 1;
            }
            return TypeOfOwnerships.Select(typeOfOwnership => typeOfOwnership.Id).Concat(new[] {0}).Max() + 1;
        }

        public static bool TooDelete(int id)
        {
            if (TypeOfOwnerships == null || TypeOfOwnerships.Count == 0)
            {
                return false;
            }
            for (var i = 0; i < TypeOfOwnerships.Count; i++)
            {
                if (TypeOfOwnerships[i].Id == id)
                {
                    TypeOfOwnerships.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public static bool TooEdit(TypeOfOwnership data)
        {
            if (TypeOfOwnerships == null)
            {
                TypeOfOwnerships = new List<TypeOfOwnership>();
            }
            if (TypeOfOwnerships.Count == 0)
            {
                TypeOfOwnerships.Add(data);
                return true;
            }
            for (var i = 0; i < TypeOfOwnerships.Count; i++)
            {
                if (TypeOfOwnerships[i].Id == data.Id)
                {
                    TypeOfOwnerships[i] = data;
                    return true;
                }
            }

            TypeOfOwnerships.Add(data);

            return false;
        }

        #endregion

        #region Specializations

        private const string fileNameSpecializations = "Specializations.txt";
        public static List<Specialization> Specializations { get; set; }

        public static bool LoadSpecialization()
        {
            var path = FileHelper.GetDataFilesPath() + fileNameSpecializations;
            Specializations = new List<Specialization>();
            if (!File.Exists(path))
            {
                return false;
            }

            var str = FileHelper.LoadFile(path, 1251);
            var lines = str.Replace("\r\n", "\r").Split('\r');
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                var obj = new Specialization(line);
                Specializations.Add(obj);
            }
            return true;
        }

        public static bool SaveSpecialization()
        {
            var path = FileHelper.GetDataFilesPath() + fileNameSpecializations;
            var sb = new StringBuilder();
            foreach (var specialization in Specializations)
            {
                sb.AppendLine(specialization.ToSaveString());
            }
            return string.IsNullOrEmpty(FileHelper.SaveFile(path, sb.ToString()));
        }

        public static int SpecGetNewId()
        {
            if (Specializations == null || Specializations.Count == 0)
            {
                return 1;
            }
            return Specializations.Select(specialization => specialization.Id).Concat(new[] { 0 }).Max() + 1;
        }

        public static bool SpecDelete(int id)
        {
            if (Specializations == null || Specializations.Count == 0)
            {
                return false;
            }
            for (var i = 0; i < Specializations.Count; i++)
            {
                if (Specializations[i].Id == id)
                {
                    Specializations.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public static bool SpecEdit(Specialization data)
        {
            if (Specializations == null)
            {
                Specializations = new List<Specialization>();
            }
            if (Specializations.Count == 0)
            {
                Specializations.Add(data);
                return true;
            }
            for (var i = 0; i < Specializations.Count; i++)
            {
                if (Specializations[i].Id == data.Id)
                {
                    Specializations[i] = data;
                    return true;
                }
            }

            Specializations.Add(data);

            return false;
        }

        #endregion

        #region Firms

        private const string fileNameFirms = "Firms.txt";
        public static List<Firm> Firms { get; set; }

        public static bool LoadFirm()
        {
            var path = FileHelper.GetDataFilesPath() + fileNameFirms;
            Firms = new List<Firm>();
            if (!File.Exists(path))
            {
                return false;
            }

            var str = FileHelper.LoadFile(path, 1251);

            var lines = str.Split(UnitSeparator);
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                var obj = new Firm(line);
                
                foreach (var data in Specializations)
                {
                    if (data.Id == obj.SpecId)
                    {
                        obj.SpecName = data.Name;
                        break;
                    }
                }

                foreach (var data in TypeOfOwnerships)
                {
                    if (data.Id == obj.TooId)
                    {
                        obj.TooName = data.Name;
                        break;
                    }
                }

                Firms.Add(obj);
            }
            return true;
        }

        public static bool SaveFirm()
        {
            var path = FileHelper.GetDataFilesPath() + fileNameFirms;
            var sb = new StringBuilder();
            foreach (var firm in Firms)
            {
                sb.Append(firm.ToSaveString());
                sb.Append(UnitSeparator);
            }
            return string.IsNullOrEmpty(FileHelper.SaveFile(path, sb.ToString()));
        }

        public static int FirmGetNewId()
        {
            if (Firms == null || Firms.Count == 0)
            {
                return 1;
            }
            
            var maxValue = 0;
            for (int i = 0; i < Firms.Count; i++)
            {
                if (Firms[i].Id > maxValue)
                {
                    maxValue = Firms[i].Id;
                }
            }
            maxValue = maxValue + 1;

            return Firms.Select(firm => firm.Id).Concat(new[] { 0 }).Max() + 1;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GuideOfBuyer.Bll
{
    public static class FileHelper
    {
        #region GetStartupPath

        /// <summary>
        /// Return startup path application
        /// </summary>
        /// <returns></returns>
        public static string GetStartupPath()
        {
            //Системная переменная возвращающая путь запуска исполняемого файла
            string s = System.AppDomain.CurrentDomain.BaseDirectory;

            #region "Выходим" на уровен корня проекта, что бы были одинаковые данные в debug и release режимах

            int i;
            i = s.IndexOf(@"\Debug", 1, s.Length - 1);
            if (i > 0)
            {
                s = s.Substring(0, i);
                i = s.IndexOf(@"\bin", 1, s.Length - 1);
                if (i > 0)
                {
                    s = s.Substring(0, i);
                }
                i = s.IndexOf(@"\obj", 1, s.Length - 1);
                if (i > 0)
                {
                    s = s.Substring(0, i);
                }
            }

            #endregion

            return s + @"\";
        }

        #endregion

        #region GetDataFilesPath

        /// <summary>
        /// Return int files path 
        /// </summary>
        /// <returns></returns>
        public static string GetDataFilesPath()
        {
            string res = GetStartupPath() + @"Data\";
            CheckFolder(res);
            return res;
        }

        #endregion

        #region CheckFolder

        /// <summary>
        /// Проверяет доступность папки, в случае отсутсвия папки создает папку
        /// </summary>
        /// <param name="path">Путь к папке</param>
        /// <returns>Пустая строка или сообщение об ошибке</returns>
        public static string CheckFolder(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    //Если папки не существует, создаем её
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }

        #endregion

        #region CheckFilePath

        /// <summary>
        /// Проверяет доступность папки куда нужно положить файл, в случае отсутсвия папки создает полный путь
        /// </summary>
        /// <param name="fileName">Полный путь к файлу</param>
        /// <returns>Успешность операции</returns>
        public static bool CheckFilePath(string fileName)
        {
            //Получаем имя папки отбрасывая имя файла
            var path = Path.GetDirectoryName(fileName);

            return string.IsNullOrEmpty(CheckFolder(path));
        }

        #endregion

        #region LoadFile

        /// <summary>
        /// Загружает содержимое файла в текстовое поле
        /// </summary>
        /// <param name="fileName">Имя файла с путём</param>
        /// <returns>Содержимое файла</returns>
        public static string LoadFile(string fileName)
        {
            try
            {
                // Считываем файл в массив байтов...
                using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    var bt = new byte[(int)fs.Length];
                    fs.Read(bt, 0, (int)fs.Length);

                    // Преобразуем массив байтов в текст с учетом 
                    // умолчальной кодовой страницы.
                    //CodePageEncoding cpe = new CodePageEncoding(0);
                    //tbTextForSearch.Text = cpe.GetString(bt);
                    return Encoding.UTF8.GetString(bt);
                }
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Загружает содержимое файла в текстовое поле /*Взято с stackoverflow.com*/
        /// </summary>
        /// <param name="fileName">Имя файла с путём</param>
        /// <param name="codePage">Кодировочная таблица</param>
        /// <returns>Содержимое файла</returns>
        public static string LoadFile(string fileName, int codePage)
        {
            try
            {
                // Считываем файл в массив байтов...
                using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    var bt = new byte[(int)fs.Length];
                    fs.Read(bt, 0, (int)fs.Length);

                    // Преобразуем массив байтов в текст с учетом 
                    // кодовой страницы по умолчанию.
                    //CodePageEncoding cpe = new CodePageEncoding(0);
                    //tbTextForSearch.Text = cpe.GetString(bt);
                    return codePage <= 0 ? Encoding.UTF8.GetString(bt) : Encoding.GetEncoding(codePage).GetString(bt);
                }
            }
            catch
            {
                return "";
            }
        }

        #endregion

        #region SaveFile

        /// <summary>
        /// Сохраняет текстовый файл
        /// </summary>
        /// <param name="fileName">Имя файла с путём</param>
        /// <param name="text">Содержимое файла</param>
        /// <returns></returns>
        public static string SaveFile(string fileName, string text)
        {
            return SaveFile(fileName, text, Encoding.GetEncoding(1251));
        }

        /// <summary>
        /// Сохраняет текстовый файл
        /// </summary>
        /// <param name="fileName">Имя файла с путём</param>
        /// <param name="text">Содержимое файла</param>
        /// <param name="codePage">Номер кодировочной таблицы</param>
        /// <returns></returns>
        public static string SaveFile(string fileName, string text, int codePage)
        {
            return SaveFile(fileName, text, Encoding.GetEncoding(codePage));
        }

        /// <summary>
        /// Сохраняет текстовый файл /*Взято с stackoverflow.com*/
        /// </summary>
        /// <param name="fileName">Имя файла с путём</param>
        /// <param name="text">Содержимое файла</param>
        /// <param name="encoding">Кодировочная таблица для сохранения</param>
        /// <returns></returns>
        public static string SaveFile(string fileName, string text, Encoding encoding)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    //Если файл существует, удаляем его
                    File.Delete(fileName);
                }

                CheckFilePath(fileName);

                using (var fs = new FileStream(fileName, FileMode.CreateNew))
                {
                    using (var sw = new StreamWriter(fs, encoding))
                    {
                        sw.Write(text);
                        sw.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        #endregion
    }
}

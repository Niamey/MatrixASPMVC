using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Core

    {
      
        public static int[,] TraverseMatrix(int[,] array)
        {
            int m = 3;
            
            int[,] array1 = new int[m, m];

            for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array1[j, i] = array[i,j];
                }
            }

            return array1;
        }
        public static List<string> ReadCSVFile(string fullPath)
        {
             List<string> read = new List<string>();
            char[] seperators = { ',', '\\', '\"' };
            StreamReader sr = new StreamReader(fullPath);

            string data = sr.ReadLine();

            while ((data = sr.ReadLine()) != null)
            {
                  read.AddRange(data.Split(seperators, StringSplitOptions.None));
            }


              return read;
        }




        public static void SaveArrayAsCSV(int[,] jaggedArrayToSave, string fileName, string path)
        {

            using (StreamWriter file = new StreamWriter(fileName))
            {

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        file.Write(jaggedArrayToSave[i, j] + ",");
                    }
                    file.Write(Environment.NewLine);
                    System.IO.File.Create(path);

                    Console.WriteLine(jaggedArrayToSave);
                }
            }
        }

        public static string[] GetFilesFromDirectory(string dirPath)
        {
            if (!Directory.Exists(dirPath))
                return null;

            var files = Directory.GetFiles(dirPath);
            return files;
        }




        public static void DeleteDirectory(string path)
        {
            if (!Directory.Exists(path))
                return;

            var files = Directory.GetFiles(path);
            var dirs = Directory.GetDirectories(path);

            foreach (var file in files)
            {

                System.IO.File.SetAttributes(file, FileAttributes.Normal);
                System.IO.File.Delete(file);
            }

            foreach (var dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(path, false);
        }

        public static string ReplaceIllegalFilenameCharacters(string filename)
        {
            return Path.GetInvalidFileNameChars().Aggregate(filename, (current, c) => current.Replace(c.ToString(), string.Empty));
        }

        public static void CreateNewDirectory(string path)
        {

            var ExistingDirectory = Directory.Exists(path);
            if (ExistingDirectory == false)
            {
                Directory.CreateDirectory(path);
            }

        }

        public static bool CheckIfFileExists(string path)
        {
            var documents = Directory.GetFiles(path);
            bool isFileEmpty = true;

            foreach (var document in documents)
            {

                string[] lines = System.IO.File.ReadAllLines(Path.Combine(path, document));

                if (lines.Length == 0)
                {
                    return true;
                }
                else
                {
                    isFileEmpty = false;

                }
            }

            return isFileEmpty;
        }

        public static void CreateAndWriteCsvFile(string path)

        {
            
                CreateNewDirectory(path);
           
            var documents = Directory.GetFiles(path);

            foreach (var document in documents)
            {

                var fileName = Path.GetFileName(document);
                if (fileName.Equals("FileForMatrixImport.csv"))
                {
                    System.IO.File.Delete(Path.Combine(path, fileName));
                }
            }

            //before your loop
            var csv = new StringBuilder();
            var csvNoData = new StringBuilder();

            //in your loop
            var column1 = "olga";
            var column2 = "loves";
            var column3 = "programming";
            //Suggestion made by KyleMit
            var line = string.Format($"1,2,3\r\n{column1},{column2},{column3}");
            var lineNoData = "1,2,3";
            csv.AppendLine(line);
            csvNoData.AppendLine(lineNoData);
        }

        public static int[,] GenerateMatrix(int[,] array)
        {
            
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = rand.Next(10);
                  
                }
            }
            return array;
        }
    }
}

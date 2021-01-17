using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFinder
{
    class Comparer
    {
        private String filePath;
        private String searchPath;
        private bool[] exist;
        byte[] hashOrig;
        HashAlgorithm hashAlg = HashAlgorithm.Create();
        
        public Comparer(String filePath, String searchPath)
        {
            this.filePath = filePath;
            this.searchPath = searchPath;
            FileStream origFile = new FileStream(filePath, FileMode.Open);
            if (Properties.Settings.Default.Hash == "" && Properties.Settings.Default.Hash != null) hashAlg = HashAlgorithm.Create(Properties.Settings.Default.Hash);
            else hashAlg = HashAlgorithm.Create();
            hashOrig = hashAlg.ComputeHash(origFile);
            origFile.Close();
        }

        public Comparer(String filePath)
        {
            this.filePath = filePath;
            FileStream origFile = new FileStream(filePath, FileMode.Open);
            if (Properties.Settings.Default.Hash == "" && Properties.Settings.Default.Hash != null) hashAlg = HashAlgorithm.Create(Properties.Settings.Default.Hash);
            else hashAlg = HashAlgorithm.Create();
            hashOrig = hashAlg.ComputeHash(origFile);
            origFile.Close();
        }

        public Comparer()
        {
            if (Properties.Settings.Default.Hash == "" && Properties.Settings.Default.Hash != null) hashAlg = HashAlgorithm.Create(Properties.Settings.Default.Hash);
            else hashAlg = HashAlgorithm.Create();
        }

        public bool compare(String searchPath)
        {


            FileStream dupFile = new FileStream(searchPath, FileMode.Open);
            byte[] hashDup = hashAlg.ComputeHash(dupFile);


            if (BitConverter.ToString(hashOrig) == BitConverter.ToString(hashDup))
            {
                dupFile.Close();
                return true;
            }
            else
             {
                dupFile.Close();
                return false;
            }
                
        }

        public String[] getFiles(String directory, String searchPattern)
        {
            IEnumerable<String> paths = GetAllFiles(directory, searchPattern);

            String[] files = new string[paths.Count()];

            long counter = 0;
            foreach (var file in paths)
            {
                files[counter] = file.ToString();
                counter++;
            }
             return files;
        }

        public bool[] compareAll(String[] directory)
        {
            exist = new bool[directory.Length];


            for (long i =0;i<directory.Length;i++)
            {
                exist[i] = compare(directory[i]);
            }

            return exist;
        }



        IEnumerable<String> GetAllFiles(string path, string searchPattern)
        {
            return System.IO.Directory.EnumerateFiles(path, searchPattern).Union(
                System.IO.Directory.EnumerateDirectories(path).SelectMany(d =>
                {
                    try
                    {
                        return GetAllFiles(d, searchPattern);
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        return Enumerable.Empty<String>();
                    }
                }));
        }


        public String[] ScanPartition(string partition, string searchPattern)
        {
            IEnumerable<String> paths = GetAllFiles(partition, searchPattern);

            String[] fileHash = new string[paths.Count()];
            long counter = 0;

            foreach (var filePath in paths)
            {
                try
                {
                    FileStream file = new FileStream(filePath, FileMode.Open);               
                    byte[] hash = hashAlg.ComputeHash(file);

                    var sBuilder = new StringBuilder();

                    for (long i = 0; i < hash.Length; i++)
                    {
                        sBuilder.Append(hash[i].ToString("x2"));
                    }

                    fileHash[counter] = sBuilder.ToString();
                    counter++;
                    file.Close();
                }
                catch (Exception e)
                {
                    fileHash[counter] = null;
                    counter++;
                }
                
            }

            return fileHash;
        }

        public bool[] findDuplicates(String[] paths)
        {
            long counter = 0;

            bool[] duplicate = new bool[paths.Count()];

            bool isDuplicate;
            for (long i =counter; i<paths.Length-1;i++)
            {
                if (String.IsNullOrEmpty(paths[i])) continue;
                String file1 = paths[i];
                for (long j =i+1;j<paths.Length;j++)
                {
                    int index = 0;
                    String file2 = paths[j];
                    isDuplicate = true;
                    if(file2 != null)
                    {
                        while (isDuplicate == true && index < file1.Length && index < file2.Length)
                        {
                            isDuplicate = fastComparing(file1, file2, index);
                            index++;
                        }
                        if(isDuplicate)
                        {
                            duplicate[j] = true;
                            duplicate[i] = true;
                        }
                        
                    }
                }
                    
            }

            return duplicate;

        }

        private Boolean fastComparing(String file1,String file2, int index)
        {
            if (file1[index] == file2[index] ) return true;
            else return false;
        }

        public long fileCount(string partition, string searchPattern)
        {

            IEnumerable < String > paths = GetAllFiles(partition, searchPattern);

            
            String[] fileBits = new string[paths.Count()];
            long counter = 0;

            foreach (var filePath in paths)
            {
                try
                {
                    FileStream file = new FileStream(filePath, FileMode.Open);
                    FileInfo fi = new FileInfo(filePath);
                    if (fi.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        fileBits[counter] = null;
                        counter++;
                        continue;
                    }

                    counter++;
                    file.Close();
                    
                }
                catch (Exception e)
                {
                    fileBits[counter] = null;
                    counter++;
                }

            }

            Array.Sort(fileBits);

            fileBits = fileBits.Where(color => !string.IsNullOrEmpty(color)).ToArray();

            
            return paths.Count();



        }


    }



}

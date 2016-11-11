﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Y.Utils.BaseUtils;
using Y.Utils.FileUtils;

namespace Y.Utils.TxtUtils
{
    public class TxtTool
    {
        public static bool Append(string file, List<string> txt)
        {
            try
            {
                DirTool.Create(Path.GetDirectoryName(file));
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    if (!ListTool.IsNullOrEmpty(txt))
                        foreach (var t in txt)
                            sw.WriteLine(t);
                }
                return true;
            }
            catch (Exception e) { }
            return false;
        }
        public static bool Append(string file, string txt)
        {
            try
            {
                DirTool.Create(Path.GetDirectoryName(file));
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine(txt);
                }
                return true;
            }
            catch (Exception e) { }
            return false;
        }
        public static bool Create(string file, string txt)
        {
            try
            {
                DirTool.Create(Path.GetDirectoryName(file));
                using (StreamWriter sw = new StreamWriter(file, false, Encoding.UTF8))
                {
                    sw.WriteLine(txt);
                }
                return true;
            }
            catch (Exception e) { }
            return false;
        }
        public static string Read(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
                {
                    string result = "", line;
                    while ((line = sr.ReadLine()) != null)
                        result += line.ToString();
                    return result;
                }
            }
            catch (Exception e) { }
            return null;
        }
        public static List<string> ReadLine(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
                {
                    List<string> result = new List<string>();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        result.Add(line.ToString());
                    return result;
                }
            }
            catch (Exception e) { }
            return null;
        }
    }
}
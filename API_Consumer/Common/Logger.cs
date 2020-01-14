using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace API_Consumer.Common
{
    #region logovanje prilikom testiranja metoda CreateXMLi ProcessXML za poruku pacs.028  - MiodragS
    public class LogWriter
    {
        private string m_exePath = string.Empty;
        private string m_logfilename = string.Empty;
        public LogWriter(string logMessage)
        {
            LogWrite(logMessage);
        }

        public LogWriter(string logMessage, bool append)
        {
            LogWrite(logMessage, append);
        }
        public void LogWrite(string logMessage)
        {

            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                string logfileName = this.GetLogFileName(DateTime.Now);

                if (!File.Exists(m_exePath + "\\" + logfileName))
                {
                    using (StreamWriter w = File.CreateText(m_exePath + "\\" + logfileName))
                    {
                        Log(logMessage, w);
                    }
                }
                else
                {
                    using (StreamWriter w = File.AppendText(m_exePath + "\\" + logfileName))
                    {
                        Log(logMessage, w);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void LogWrite(string logMessage, bool append)
        {

            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                string logfileName = string.Empty;
                if (append)
                {
                    logfileName = "SepaAdapter2019_Log.txt";
                }
                else
                {
                    logfileName = this.GetLogFileName(DateTime.Now);
                }

                if (!File.Exists(m_exePath + "\\" + logfileName))
                {
                    using (StreamWriter w = File.CreateText(m_exePath + "\\" + logfileName))
                    {
                        Log(logMessage, w);
                    }
                }
                else
                {
                    using (StreamWriter w = File.AppendText(m_exePath + "\\" + logfileName))
                    {
                        Log(logMessage, w);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                //txtWriter.Write("\r\nLog Entry : ");
                //txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                //    DateTime.Now.ToLongDateString());
                //txtWriter.WriteLine("  :");
                //txtWriter.WriteLine("  :{0}", logMessage);
                //txtWriter.WriteLine("-------------------------------");
                string lineToWrite = string.Format("{0}.{1}.{2} {3}:{4}:{5}==>> {6}", DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year.ToString(), DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"), DateTime.Now.Second.ToString("00"), logMessage);
                txtWriter.WriteLine(lineToWrite);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string GetLogFileName(DateTime dateTime)
        {
            //dateTime = DateTime.Now;
            return string.Format("adapter_log_{0}{1}{2}.txt", dateTime.Day.ToString("00"), dateTime.Month.ToString("00"), dateTime.Year.ToString());
        }


    }
    #endregion
}

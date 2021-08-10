using Globo.ServiceApi.Configurations;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Globo.ServiceApi.Dtos
{
    public class Parameters
    {
        public Parameters(IOptions<AppSettings> settings)
        {   
            Settings = settings;
        }

        public IOptions<AppSettings> Settings { get; private set; }
        public string StartDate { get; private set; }
        public string EndDate { get; private set; }
        public string RequestUrlOne { get; private set; }
        public string RequestUrlTwo { get; private set; }
        public string RequestUrlThree { get; private set; }
        public string Equipes { get; set; }
        public string Equipamentos { get; set; }
        //public List<string> ResourceCodes { get; private set; }

        public void BuildCDEParams(int siteId, int rangeIni, int rangeFinal)
        {
            StartDate = DateTime.Now.AddHours(-rangeIni).ToString("O", CultureInfo.CreateSpecificCulture("pt-BR"));

            EndDate = DateTime.Now.AddHours(rangeFinal).ToString("O", CultureInfo.CreateSpecificCulture("pt-BR"));

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(Settings.Value.Query, StartDate, EndDate, CdeGroups(), siteId);

            RequestUrlOne = Settings.Value.DefaultURl + sb.ToString() + Settings.Value.ResourceColumnCDE;

            BuildCDERequestUrlTwo();

            BuildCDERequestUrlThree();
        }

        public void BuildCDERequestUrlTwo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Settings.Value.DefaultURl);
            sb.Append(Settings.Value.QueryTwo);
            sb.Append(Settings.Value.ResourceColumnCDE);

            RequestUrlTwo = sb.ToString();
        }

        public void BuildCDERequestUrlThree()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Settings.Value.DefaultURl);
            sb.Append(Settings.Value.QueryThree);
            sb.Append(Settings.Value.ResourceColumnCDE);

            RequestUrlThree = sb.ToString();

        }

        public void SetWosInQuery(List<string> Wos)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Wos.Count(); i++)
            {
                if (i == 0)
                {
                    sb.Append(@"""" + Wos[0] + @"""");
                }
                else
                {
                    sb.Append(@",""" + Wos[i] + @"""");
                }
            }

            var ver = sb.ToString();

            StringBuilder newUrlTwo = new StringBuilder();

            newUrlTwo.AppendFormat(RequestUrlTwo, "259-1");

            RequestUrlTwo = newUrlTwo.ToString();

            StringBuilder newUrlThree = new StringBuilder();

            newUrlThree.AppendFormat(RequestUrlThree, sb.ToString());

            RequestUrlThree = newUrlThree.ToString();


        }

        public string CdeGroups()
        {
            var groups = "";

            for (int i = 0; i < Settings.Value.CDEGroups.Length; i++)
            {
                if(i == Settings.Value.CDEGroups.Length - 1)
                {
                    groups += Settings.Value.CDEGroups[i];
                }
                else
                {
                    groups += Settings.Value.CDEGroups[i] + ",";
                }
                
            }

            return groups;
        }
    }
}

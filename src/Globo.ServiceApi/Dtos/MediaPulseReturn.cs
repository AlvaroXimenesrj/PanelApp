namespace Globo.ServiceApi.Dtos
{
    public class MediaPulseReturn
    {
        public string trx_begin_dt { get; set; }
        public string trx_end_dt { get; set; }
        public int trx_no { get; set; }
        public string wo_desc { get; set; }
        public string customer_name { get; set; }
        public string job_desc { get; set; }
        public string wo_custom_2 { get; set; }
        public int trx_type_no { get; set; }
        public string origin_trx_begin_dt { get; set; }
        public string origin_trx_end_dt { get; set; }

        public wonoseq wo_no_seq { get; set; }
        public groupcode group_code { get; set; }
        public resourcecode resource_code { get; set; }
        public resourcetypeno resource_type_no { get; set; }
        public sch_resource_default_location_no sch_resource_default_location_no { get; set; }

    }

    public class wonoseq
    {
        public string wo_no_seq { get; set; }
    }
    public class groupcode
    {
        public string group_desc { get; set; }
        public string group_code { get; set; }
    }
    public class resourcecode
    {
        public string resource_desc { get; set; }
        public string resource_code { get; set; }
    }
    public class resourcetypeno
    {
        public string resource_type_desc { get; set; }
        public int resource_type_no { get; set; }

    }


    public class sch_resource_default_location_no
    {
        public string resource_location_desc { get; set; }
        public int resource_location_no { get; set; }
    }
}

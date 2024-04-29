namespace MoviesApp.Model
{
    public class CastList
    {
        public int Id { get; set; }
        public List<Cast>? Cast { get; set; }
        public List<Crew>? Crew { get; set; }
    }

    public class Cast
    {
        public bool Adult { get; set; }
        public int Gender { get; set; }
        public int Id { get; set; }
        public string Known_for_department { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Original_name { get; set; } = string.Empty;
        public double Popularity { get; set; }
        public string Profile_path { get; set; } = string.Empty;
        public int Cast_id { get; set; }
        public string Character { get; set; } = string.Empty;
        public string Credit_id { get; set; } = string.Empty;
        public int Order { get; set; }
    }

    public class Crew
    {
        public bool Adult { get; set; }
        public int Gender { get; set; }
        public int Id { get; set; }
        public string Known_for_department { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Original_name { get; set; } = string.Empty;
        public double Popularity { get; set; }
        public string Profile_path { get; set; } = string.Empty;
        public string Credit_id { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Job { get; set; } = string.Empty;
    }
}

namespace DeepakTest_Project
{
    public class ApiResponse
    {
        public int statusCode { get; set; }

        public string message { get; set; }

        public string version { get; set; }

        public object data { get; set; }

        public bool Success { get; internal set; }

    }
}

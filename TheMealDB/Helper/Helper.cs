namespace TheMealDB.Helper
{
    public static class Helper
    {
        public static T FromJson<T>(this string jsonData)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonData);
        }
        public static string ToJson(this object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        public static Models.Category SelectedCategory { get; set; }
        public static Models.Meal SelectedMeal { get; set; }
    }
}

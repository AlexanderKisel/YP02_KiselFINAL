using System.Data;

namespace Mydl
{
    public static class ForEdit
    {
        public static int Id { get; set; }
        public static string Title { get; set; }
        public static int CountInPack { get; set; }
        public static string Unit { get; set; }
        public static double? CountInStock { get; set; }
        public static double MinCount { get; set; }
        public static string? Description { get; set; }
        public static decimal Cost { get; set; }
        public static string? Image { get; set; }
        public static int MaterialTypeId { get; set; }
    }
}
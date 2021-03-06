using Common.Attributes;

namespace Models.Utils
{
    public class Pagging: FilterDay
    {
        /// <summary>
        /// number of take page
        /// </summary>
        [Filtering]
        public int take { get; set; } = 1;
        /// <summary>
        /// number of size of the page
        /// </summary>
        [Filtering]
        public int size { get; set; } = 10;
        /// <summary>
        /// property name as well Name of Owner it will be == 'Name', only the property
        /// </summary>
        public string? orderAsc { get; set; }
        /// <summary>
        /// property name as well Name of Owner it will be orderAsc: 'Name', only the property
        /// </summary>
        public string? orderDesc { get; set; }
        /// <summary>
        /// filter yo need to pass a json with the property and value for filtering, only support one filter
        /// as well == {    Name: 'Pepito'  }, the filter is with contains char
        /// </summary>
        public string? filter { get; set; }
    }
}

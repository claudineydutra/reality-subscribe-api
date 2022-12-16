using Microsoft.AspNetCore.Mvc;

namespace ICM.Core.Application.Common
{
    public class PagedResult<T> where T : class
    {
        public IList<T> Rows { get; set; }
        public PagedResultParameters Parameters { get; set; }

        public PagedResult()
        {
            Parameters = new PagedResultParameters();
        }

        public PagedResult<T> EnsureParameters(ref PagedResultParameters parameters)
        {
            SetParameters(parameters);

            return this;
        }

        protected void SetParameters(PagedResultParameters parameters)
        {
            if (parameters != null)
            {
                Parameters = parameters;
            }
            else if (Parameters != null)
            {
                _ = Parameters;
            }
        }
    }

    public class PagedResultParameters
    {
        [FromQuery]
        public string SearchString { get; set; }
        [FromQuery]
        public int Status { get; set; }
        [FromQuery]
        public string SortDir { get; set; }
        [FromQuery]
        public string SortColumn { get; set; }
        [FromQuery]
        public int PageCurrent { get; set; }
        [FromQuery]
        public int PageCount { get; set; }
        [FromQuery]
        public int PageSize { get; set; }
        [FromQuery]
        public int RowCount { get; set; }
        [FromQuery]
        public bool KeyValueOnly { get; set; }
        [FromQuery]
        public bool Full { get; set; }
        [FromQuery]
        public DateTime? StartDate { get; set; }
        [FromQuery]
        public DateTime? EndDate { get; set; }

        public int FirstRowOnPage
        {
            get { return (PageCurrent - 1) * PageSize + 1; }
        }

        public int LastRowOnPage
        {
            get { return Math.Min(PageCurrent * PageSize, RowCount); }
        }

        public PagedResultParameters()
        {
            PageSize = 100;
            SortDir = "asc";
        }

        public bool IsSortDirAscending()
        {
            return SortDir == "asc";
        }
    }
}
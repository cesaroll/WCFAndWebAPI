using MEP.Models.Data;

namespace MEP.DataAccess.Data
{
    public class App : IApp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
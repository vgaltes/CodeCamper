using System.Data.Entity;

namespace CodeCamper.Data.SampleData
{
    public class CodeCamperDatabaseInitializer : DropCreateDatabaseIfModelChanges<CodeCamperDbContext>
    {
        protected override void Seed(CodeCamperDbContext context)
        {
            base.Seed(context);
        }
    }
}

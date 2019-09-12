using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Magelan.Repositories.DbContexts {
    
    public class GuidStringGenerator : ValueGenerator<string>
    {
        private readonly SequentialGuidValueGenerator _guidGenerator 
            = new SequentialGuidValueGenerator();

        public override string Next(EntityEntry entry) 
            => _guidGenerator.Next(entry).ToString();

        public override bool GeneratesTemporaryValues 
            => false;
    }
}
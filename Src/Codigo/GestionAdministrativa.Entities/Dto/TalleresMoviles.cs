using System;
using Framework.Common.Mapping;

namespace GestionAdministrativa.Entities.Dto
{
    public class TalleresMoviles :IMapFrom<TalleresMovile>
    {
        public Guid MovilId { get; set; }
    }
}
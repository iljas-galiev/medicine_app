using MedicineApplication.Core;

namespace MedicineApplication.Model.Offer
{
    public class OfferRepository : EntityRepository<OfferEntity>
    {
        public override string TableName()
        {
            return "offer";
        }

        public override Entity BeforeSave(Entity entity)
        {
            OfferEntity offer = (OfferEntity) entity;

            return offer;
        }
    }
}

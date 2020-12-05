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

            if (offer.Title.Length < 1) offer.AddError("Title", "Поле \"названи\" не должно быть пустым");
            if (offer.Brand.Length < 1) offer.AddError("Brand", "Поле \"Марка\" не должно быть пустым");
            if (offer.Model.Length < 1) offer.AddError("Model", "Поле \"Модель\" не должно быть пустым");
            if (offer.Phone.Length < 1) offer.AddError("Phone", "Поле \"Телефон\" не должно быть пустым");
            if (offer.Email.Length < 1) offer.AddError("Email", "Поле \"E-mail\" не должно быть пустым");
            if (offer.Description.Length < 1) offer.AddError("Description", "Поле \"Описание\" не должно быть пустым");
            if (offer.Price < 1) offer.AddError("Price", "Поле \"Цена\" не должно быть пустым");

            return offer;
        }
    }
}

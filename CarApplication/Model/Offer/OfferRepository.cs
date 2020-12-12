using System;
using CarApplication.Core;
using CarApplication.Model.User;
using LinqToDB;

namespace CarApplication.Model.Offer
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

            if (string.IsNullOrEmpty(offer.Title))
                offer.AddError("Название", "Поле не должно быть пустым");
            if (string.IsNullOrEmpty(offer.Brand)) offer.AddError("Марка", "Поле не должно быть пустым");
            if (string.IsNullOrEmpty(offer.Model)) offer.AddError("Модель", "Поле не должно быть пустым");
            if (string.IsNullOrEmpty(offer.Phone)) offer.AddError("Телефон", "Поле не должно быть пустым");
            if (string.IsNullOrEmpty(offer.Email)) offer.AddError("E-mail", "Поле не должно быть пустым");
            if (string.IsNullOrEmpty(offer.Description))
                offer.AddError("Описание", "Поле не должно быть пустым");
            if (offer.Price < 1) offer.AddError("Цена", "Поле не должно быть пустым");


            if (!UserRepository.IsValidEmail(offer.Email)) offer.AddError("E-mail", "Поле некорректно");
            if (!UserRepository.IsValidPhone(offer.Phone)) offer.AddError("Телефон", "Поле некорректно");


            if(offer.IsNewRecord) offer.CreatedAt = DateTime.Now;
            offer.UpdatedAt = DateTime.Now;

            return offer;
        }

        public int Save(OfferEntity entity)
        {
            int id = 0;
            if (!Validate(entity)) return 0;

            if (!entity.IsNewRecord)
            {
                id = Db.Dc.Update(entity);
            }
            else
            {
                id = Db.Dc.InsertWithInt32Identity(entity);
            }

            return id;
        }

        public bool Delete(Entity entity)
        {
            OfferEntity offer = (OfferEntity) entity;
            return Db.Dc.Delete(offer) != 0;
        }
    }
}

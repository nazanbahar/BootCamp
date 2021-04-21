
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string CannotBeAccepted = "Bu Kategori için ürün kabul edilemez";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductsListed ="Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok.";

        public static string RegistrationAdded = "Kayıt eklendi";
        public static string RecordListed = "Kayıt listelendi";
        public static string AddedCart = "Sepete eklendi";
        //basket
        public static string ProductNotFound = "Ürün bulunmadı...";
    }
}

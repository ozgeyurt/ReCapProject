using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded="Yeni Araba Başarıyla Eklendi";
        public static string CarDeleted = "Araba başarıyla silindi";
        public static string CarUpdated = "Güncelleme başarılı";
        public static string DescriptionInvalid = "Araba İsmi En Az 2 Karakter Olmalı";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string CarsListed = "Arabalar Listelendi";


        public static string CustomerAdded = "Yeni müşteri Başarıyla Eklendi";
        public static string CustomerDeleted = "Müşteri başarıyla silindi";
        public static string CustomerUpdated = "Müşteri bilgileri Güncellendi";
        internal static string CustomerrsListed = "Müşteriler  Listelendi";

        public static string UserAdded = "Kullanıcı Başarıyla Eklendi";
        public static string UserDeleted = "Kullanıcı başarıyla silindi";
        public static string UserUpdated = "Kullanıcı bilgileri Güncellendi";
        internal static string UsersListed = "Kullanıcılar  Listelendi";

        public static string RentalAdded = "Kiralama Bilgisi Eklendi";
        public static string RentalDeleted = "Kiralama Bilgisi silindi";
        public static string RentalUpdated = "Kiralama Bilgisi Güncellendi";
        internal static string RentalsListed = "Kiralama Bilgileri  Listelendi";

    }
}

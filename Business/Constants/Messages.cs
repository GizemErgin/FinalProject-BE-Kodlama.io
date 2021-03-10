using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Temel mesajları barındırır. Tekrar tekrar yazmaktan kurtarır.
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımdadır";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla 10 adet ürün olabilir.";
        public static string ProductNameAlreadyExist = "Eklemeye çalıştığınız ürün veritabanında vardır.";
        public static string CategoryMoreThan15 = "Mevcut kategori sayısı 15'i geçti, ürün eklenemez.";
        public static string AuthorizationDenied = "Yetkiniz yok";



        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";


    }
}

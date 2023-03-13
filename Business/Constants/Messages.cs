using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages<T>
    {
        public static string AddedSuccessMessage = $"{nameof(T)} added";
        public static string AddedErrorMessage = $"{nameof(T)} added is unsuccess";
        public static string UpdatedSuccessMessage = $"{nameof(T)} updated";
        public static string UpdatedErrorMessage = $"{nameof(T)} updated is unsuccess";
        public static string ListedMessage = $"{nameof(T)} listesi oluşturuldu";
        public static string CarNameOrDailyPriceErrorMessage = "Araba ismi minimum 2 karakter olmalı ve araba günlük fiyatı 0'dan büyük olmalıdır.";
    }
}

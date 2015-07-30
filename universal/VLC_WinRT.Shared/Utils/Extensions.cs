﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using VLC_WinRT.Model;
using VLC_WinRT.Model.Music;

namespace VLC_WinRT.Utils
{
    public static class Extensions
    {
        public static bool Contains(this string source, string value, StringComparison comparisonType)
        {
            return source.IndexOf(value, comparisonType) >= 0;
        }

        public static ObservableCollection<T> ToObservable<T>(this IEnumerable<T> source)
        {
            return new ObservableCollection<T>(source);
        }

        public static async Task<ObservableCollection<T>> ToObservableAsync<T>(this Task<List<T>> source)
        {
            return new ObservableCollection<T>(await source);
        }

        public static ObservableCollection<IVLCMedia> ToPlaylist(this IEnumerable<TrackItem> source)
        {
            return new ObservableCollection<IVLCMedia>(source);
        }

        public static List<TrackItem> ToTrackItemPlaylist(this IEnumerable<IVLCMedia> source)
        {
            return source.OfType<TrackItem>().ToList();
        }

        public static string ToUpperFirstChar(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

    }
}

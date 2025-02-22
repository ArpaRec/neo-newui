﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace gamevault.Models
{
    public enum AppConfigKey
    {
        Username,
        Password,
        Email,
        InstallDrive,
        RootPath,
        Executable,
        BackgroundStart,
        ServerUrl,
        LibStartup,
        AutoExtract,
        ExtractionFinished,
        RunningInTrayMessage,
        DownloadLimit,
        InstalledGamesOpen,
        LaunchParameter,
        ShowRawgTitle
    }
    public static class AppFilePath
    {
        internal static string ImageCache = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/cache/images";
        internal static string OfflineProgress = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/cache/prgs";
        internal static string OfflineCache = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/cache/local";
        internal static string ConfigDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/config";
        internal static string UserFile = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/config/user";
        internal static string IgnoreList = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/cache/ignorelist";
        internal static string ErrorLog = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/errorlog";


        internal static void InitDebugPaths()
        {
            ImageCache = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/debug/cache/images";
            OfflineProgress = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/debug/cache/prgs";
            OfflineCache = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/debug/cache/local";
            ConfigDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/debug/config";
            UserFile = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/debug/config/user";
            IgnoreList = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/debug/cache/ignorelist";
            ErrorLog = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Neo/debug/errorlog";
        }
    }
    public static class Globals
    {
        internal static string[] SupportedExecutables = new string[] { "EXE", "BAT", "COM", "CMD", "INF", "IPA", "OSX", "PIF", "RUN", "WSH", "LNK", "SH" };
    }
}

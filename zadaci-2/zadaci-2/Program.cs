﻿using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            byte[] key = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 11, 12, 13, 14, 15, 16 };

            // make readable bmpA
            await AES.AESCryptParallel(Constants.TestFilesPath + "B2A.bmp", key, Constants.Results_A4_2_FilesPath + "B2A_encr.bmp");
            await AES.AESDecryptParallel(Constants.Results_A4_2_FilesPath + "B2A_encr.bmp", key, Constants.Results_A4_2_FilesPath + "B2A_decrypted.bmp");
            byte[] originalBmp = FileSystemService.ReadAllBytes(Constants.TestFilesPath + "B2A.bmp");
            byte[] cryptedBmp = FileSystemService.ReadAllBytes(Constants.Results_A4_2_FilesPath + "B2A_encr.bmp");
            FileSystemService.WriteBmpBytes(Constants.Results_A4_2_FilesPath + "B2A_encryptedReadable.bmp", originalBmp, cryptedBmp);
            Console.WriteLine(await MD5.MD5Hash(Constants.TestFilesPath + "B2A.bmp"));
            Console.WriteLine(await MD5.MD5Hash(Constants.Results_A4_2_FilesPath + "B2A_decrypted.bmp"));
            Console.WriteLine();

            // make readable bmpB
            await AES.AESCryptParallel(Constants.TestFilesPath + "B2B.bmp", key, Constants.Results_A4_2_FilesPath + "B2B_encr.bmp");
            await AES.AESDecryptParallel(Constants.Results_A4_2_FilesPath + "B2B_encr.bmp", key, Constants.Results_A4_2_FilesPath + "B2B_decrypted.bmp");
            originalBmp = FileSystemService.ReadAllBytes(Constants.TestFilesPath + "B2B.bmp");
            cryptedBmp = FileSystemService.ReadAllBytes(Constants.Results_A4_2_FilesPath + "B2B_encr.bmp");
            FileSystemService.WriteBmpBytes(Constants.Results_A4_2_FilesPath + "B2B_encryptedReadable.bmp", originalBmp, cryptedBmp);

            // make readable bmpC
            await AES.AESCryptParallel(Constants.TestFilesPath + "B2C.bmp", key, Constants.Results_A4_2_FilesPath + "B2C_encr.bmp");
            await AES.AESDecryptParallel(Constants.Results_A4_2_FilesPath + "B2C_encr.bmp", key, Constants.Results_A4_2_FilesPath + "B2C_decrypted.bmp");
            originalBmp = FileSystemService.ReadAllBytes(Constants.TestFilesPath + "B2C.bmp");
            cryptedBmp = FileSystemService.ReadAllBytes(Constants.Results_A4_2_FilesPath + "B2C_encr.bmp");
            FileSystemService.WriteBmpBytes(Constants.Results_A4_2_FilesPath + "B2C_encryptedReadable.bmp", originalBmp, cryptedBmp);

            // make readable bmpD
            await AES.AESCryptParallel(Constants.TestFilesPath + "B2D.bmp", key, Constants.Results_A4_2_FilesPath + "B2D_encr.bmp");
            await AES.AESDecryptParallel(Constants.Results_A4_2_FilesPath + "B2D_encr.bmp", key, Constants.Results_A4_2_FilesPath + "B2D_decrypted.bmp");
            originalBmp = FileSystemService.ReadAllBytes(Constants.TestFilesPath + "B2D.bmp");
            cryptedBmp = FileSystemService.ReadAllBytes(Constants.Results_A4_2_FilesPath + "B2D_encr.bmp");
            FileSystemService.WriteBmpBytes(Constants.Results_A4_2_FilesPath + "B2D_encryptedReadable.bmp", originalBmp, cryptedBmp);

            // file 100MB and check if MD5 hash is equal
            await AES.AESCryptParallel(Constants.TestFilesPath + "100MB.zip", key, Constants.Results_A4_2_FilesPath + "100MB_encrypted.zip");
            await AES.AESDecryptParallel(Constants.Results_A4_2_FilesPath + "100MB_encrypted.zip", key, Constants.Results_A4_2_FilesPath + "100MB_decrypted.zip");
            Console.WriteLine(await MD5.MD5Hash(Constants.TestFilesPath + "100MB.zip"));
            Console.WriteLine(await MD5.MD5Hash(Constants.Results_A4_2_FilesPath + "100MB_decrypted.zip"));

            // file 1GB and check if MD5 hash is equal
            //await AES.AESCryptParallel(Constants.TestFilesPath + "1GB.zip", key, Constants.Results_A4_2_FilesPath + "1GB_encrypted.zip");
            //await AES.AESDecryptParallel(Constants.Results_A4_2_FilesPath + "1GB_encrypted.zip", key, Constants.Results_A4_2_FilesPath + "1GB_decrypted.zip");
            //Console.WriteLine(await MD5.MD5Hash(Constants.TestFilesPath + "1GB.zip"));
            //Console.WriteLine(await MD5.MD5Hash(Constants.Results_A4_2_FilesPath + "1GB_decrypted.bmp"));
        }
    }
}

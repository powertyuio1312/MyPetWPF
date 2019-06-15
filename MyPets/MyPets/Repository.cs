using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;
using MyPets.Models;
using MyPets.Utils;

namespace MyPets.ViewModels
{
    public class Repository : IRepository<USER,KIND,PET, PETSPROGRESS>
    {
        static DContext db;

        static private USER currUser;
        public static string lang = "US";
        public static USER CurrUser { get => currUser; set => currUser = value; }
        

        public Repository()
        {
            db = new DContext();

        }

        public IEnumerable<USER> GetUsersList()
        {
            return db.USERS.ToList();
        }

        public IEnumerable<KIND> GetKindsList()
        {
            return db.KINDS.ToList();
        }

        public IEnumerable<PETSPROGRESS> GetProgressList()
        {
            return db.PETSPROGRESSes.ToList();
        }

        public USER GetUser(int id)
        {
            USER user = new USER();
            try
            {
                user = db.USERS.Find(id);

                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return user;
            }
        }
        

        public IEnumerable<KIND> GetKinds(int id)
        {
            return db.KINDS.ToList().Where(p => p.typeID == id);
        }

        public IEnumerable<PET> LoadUsersPetsInto(int userID)
        {
            List<PET> pets = new List<PET>();
            try
            {
                pets = db.PETS.Where(p => p.userID == userID).ToList();
                return pets;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return pets;
            }
        }

        public IEnumerable<PET> PetInfo(string petName)
        {
            List<PET> pets = new List<PET>();
            try
            {
                pets = db.PETS.Where(p => p.petNAME == petName).ToList();
                return pets;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return pets;
            }
        }

        public USER GetUser(string login, string password)
        {
            USER user = new USER();
            try
            {
                user = db.USERS.FirstOrDefault(p => p.userLOGIN.Equals(login) && p.userPASSWORD.Equals(password));

                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return user;
            }
        }

        public PET GetPet(int id)
        {
            PET pet = new PET();
            try
            {
                pet = db.PETS.Find(id);

                return pet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return pet;
            }
        }

        

        public KIND GetKind(int id)
        {
            KIND kind = new KIND();
            try
            {
                kind = db.KINDS.Find(id);

                return kind;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return kind;
            }
        }

        public bool CreateNewUser(USER user)
        {

            try
            {
                var tempUser = db.USERS.FirstOrDefault(u => u.userLOGIN.Equals(user.userLOGIN));
                if (tempUser == null)
                {
                    using (MD5 md5hash = MD5.Create())
                    {
                        var hashPass = md5Hasher.GetMd5Hash(md5hash, user.userPASSWORD);
                        user.userPASSWORD = hashPass;

                        db.USERS.Add(user);
                        
                        db.SaveChanges();

                        Repository.CurrUser = user;
                    }
                    return true;
                }
                return false;
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CreateNewPet(string name, string kind, string weight, string age, bool gender, bool type, bool photo)
        {
            try
            {
                if (type == false)
                {
                    PET cat = new PET();

                    cat.userID = CurrUser.userID;

                    cat.petNAME = name;
                    cat.petKIND = int.Parse(kind);
                    cat.petWEIGHT = int.Parse(weight);
                    cat.petAGE = int.Parse(age);

                    cat.petTYPE = 1;

                    if (gender == false)
                    {
                        cat.petGENDER = "м";
                    }
                    else
                    {
                        cat.petGENDER = "ж";
                    }

                    if (photo)
                    {

                        OpenFileDialog dlg = new OpenFileDialog();
                        dlg.InitialDirectory = "";
                        dlg.Filter = "Image files (*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";
                        if (dlg.ShowDialog() == true)
                        {
                            byte[] imageData;
                            string selectedFileName = dlg.FileName;
                            using (FileStream fs = new FileStream(selectedFileName, FileMode.Open))
                            {
                                imageData = new byte[fs.Length];
                                fs.Read(imageData, 0, imageData.Length);
                            }

                            cat.PHOTO = imageData;

                        }
                    }

                    db.PETS.Add(cat);
                    db.SaveChanges();

                }
                else
                {
                    PET dog = new PET();

                    dog.userID = CurrUser.userID;

                    dog.petNAME = name;
                    dog.petKIND = int.Parse(kind);
                    dog.petWEIGHT = int.Parse(weight);
                    dog.petAGE = int.Parse(age);

                    dog.petTYPE = 2;


                    if (gender == false)
                    {
                        dog.petGENDER = "м";
                    }
                    else
                    {
                        dog.petGENDER = "ж";
                    }

                    if (photo)
                    {
                        OpenFileDialog dlg = new OpenFileDialog();
                        dlg.InitialDirectory = "";
                        dlg.Filter = "Image files (*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";

                        if (dlg.ShowDialog() == true)
                        {

                            byte[] imageData;
                            string selectedFileName = dlg.FileName;
                            using (FileStream fs = new FileStream(selectedFileName, FileMode.Open))
                            {
                                imageData = new byte[fs.Length];
                                fs.Read(imageData, 0, imageData.Length);
                            }

                            dog.PHOTO = imageData;

                        }
                    }

                    db.PETS.Add(dog);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public BitmapImage ConvertByteArrayToImage(byte[] array)
        {
            if (array != null)
            {
                using (var ms = new MemoryStream(array, 0, array.Length))
                {
                    var image = new BitmapImage();
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.StreamSource = ms;
                    image.EndInit();
                    return image;
                }
            }
            return null;
        }

        

        //private byte[] ConvertImageToByteArray(string fileName)
        //{
        //    Bitmap bitMap = new Bitmap(fileName);
        //    ImageFormat bmpFormat = bitMap.RawFormat;
        //    var imageToConvert = Image.FromFile(fileName);
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        imageToConvert.Save(ms, bmpFormat);
        //        return ms.ToArray();
        //    }
        //}
        
        public void AddProgress(PETSPROGRESS progress)
        {
            try
            {
                
                db.PETSPROGRESSes.Add(progress);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Dispose() { }

        public List<string> GetCare()
        {
            return db.CAREs.Select(c => c.Care1).ToList();
        }

        public List<string> GetIlls()
        {
            return db.CAREs.Select(c => c.Ills).ToList();
        }

        public List<string> GetVacina()
        {
            return db.CAREs.Select(c => c.Vacina).ToList();
        }

        public void DeletePet(string name)
        {
            PET pet = PetInfo(name).Single();

            List<PETSPROGRESS> progress = new List<PETSPROGRESS>();
            progress = db.PETSPROGRESSes.Where(p => p.petID == pet.petID).ToList();
            if (progress.Count > 0)
            {
                foreach (PETSPROGRESS p in progress)
                {
                    db.PETSPROGRESSes.Remove(p);
                }
            }

            db.PETS.Remove(db.PETS.Where(p => p.petID == pet.petID).Single());
            db.SaveChanges();
        }
    }
}

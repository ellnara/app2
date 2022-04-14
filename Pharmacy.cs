using ConsoleApp15.Exceptions;
using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Pharmacy
    {
        private int _medicineLimit { get; set; }
        List<Medicine> ListOfMedicine = new List<Medicine>();
        public Pharmacy(int medicineLimit)
        {
            _medicineLimit = medicineLimit;

        }
        
        public void AddMedicine(Medicine medicine)
        {
            if (ListOfMedicine.Count == 0)
            {
                ListOfMedicine.Add(medicine);
            }
            else
            {
                if (ListOfMedicine.Count < _medicineLimit)
                {
                    foreach (var item in ListOfMedicine)
                    {
                        if (item.Name != medicine.Name)
                        {
                            ListOfMedicine.Add(medicine);
                            break;
                        }
                        else
                        {
                            throw new MedicineAlreadyExistsException();
                        }
                    }
                }
                else
                {
                    throw new CapacityLimitException();
                }
            }
        }
        public void GetAllMedicines()
        {
            foreach (var item in ListOfMedicine)
            {
                if (item.IsDeleted==false)
                {
                    Console.WriteLine($"Id: {item.Id}\nName: {item.Name}\nPrice: {item.Price}\nCount: {item.Count}\nIs deleted: {item.IsDeleted}\n");
                }
              
            }
        }
        public void FilterMedicinesByPrice(double minPrice, double maxPrice)
        {
            List<Medicine> FilteredList = new List<Medicine>();
            foreach (var item in ListOfMedicine)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice && item.IsDeleted==false)
                {
                    FilteredList.Add(item);
                }
            }
            FilteredList.Sort((a, b) => a.Price.CompareTo(b.Price));
            foreach (var item in FilteredList)
            {
                Console.WriteLine($"Id: {item.Id}\nName: {item.Name}\nPrice: {item.Price}\nCount: {item.Count}\nIs deleted: {item.IsDeleted}\n");
            }
        }
        public void GetMedicineById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceExceptionn();
            }
            else
            {
                foreach (var item in ListOfMedicine)
                {
                    if (item.Id == id && item.IsDeleted == false)
                    {
                        Console.WriteLine($"Id: {item.Id}\nName: {item.Name}\nPrice: {item.Price}\nCount: {item.Count}\nIs deleted: {item.IsDeleted}\n");
                    }
                }
            }
        }
        public void DeleteMedicineById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceExceptionn();
            }
            else
            {
                if (ListOfMedicine[id.Value-1].IsDeleted==false)
                {
                    ListOfMedicine[id.Value-1].IsDeleted = true;
                }
                else
                {
                    throw new NotFoundException();
                }
            }
        }
        public void EditMedicineEmail(int? id, string name)
        {
            bool IsExist = false;
            if (id == null || name == null)
            {
                throw new NullReferenceExceptionn();
            }
            else
            {
                foreach (var item in ListOfMedicine)
                {
                    if (item.Id == id && item.IsDeleted == false)
                    {
                        item.Name = name;
                        IsExist = true;
                    }
                }
                if (IsExist==false)
                {
                    throw new NotFoundException();
                }
            }
        }

    }
}

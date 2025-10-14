using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");
            Hospital hospital = new Hospital();

            // doctors
            hospital.AddDoctor(new Doctor(1, "Gregor Smit", "Therapist"));
            hospital.AddDoctor(new Doctor(2, "Tony Briba", "Ophthalmologist"));
            hospital.AddDoctor(new Doctor(3, "Saimon Henkock", "Endocrinologist"));

            // patients
            hospital.RegisterPatient(new Patient(1, "Bob Mukaf", 22));
            hospital.RegisterPatient(new Patient(2, "Tom Redcliff", 44));
            hospital.RegisterPatient(new Patient(3, "Ruby Joker", 66));

            // rooms
            hospital.CreateRoom(new HospitalRoom(404, 2));
            hospital.CreateRoom(new HospitalRoom(606, 2));
            hospital.CreateRoom(new HospitalRoom(808, 2));

            // hospitalization
            hospital.HospitalizePatient(1, 404);
            hospital.HospitalizePatient(2, 404);
            hospital.HospitalizePatient(3, 404);

            // medical records
            var doctor1 = hospital.Doctors.FirstOrDefault(d => d.Id == 1);
            var doctor2 = hospital.Doctors.FirstOrDefault(d => d.Id == 2);
            var doctor3 = hospital.Doctors.FirstOrDefault(d => d.Id == 3);
            var patient1 = hospital.Patients.FirstOrDefault(p => p.Id == 1);
            var patient2 = hospital.Patients.FirstOrDefault(p => p.Id == 2);
            var patient3 = hospital.Patients.FirstOrDefault(p => p.Id == 3);

            hospital.AddMedicalRecord(new MedicalRecord(patient1, doctor1, DateTime.Now, "Check-out in 1 week"));
            hospital.AddMedicalRecord(new MedicalRecord(patient2, doctor2, DateTime.Now, "Check-out in 2 week"));
            hospital.AddMedicalRecord(new MedicalRecord(patient3, doctor3, DateTime.Now, "Check-out in 3 week"));

            // history
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            // statistics
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
using Zadatak_Novena.Models;

namespace Zadatak_Novena.Repository
{
    public class AktualnostiRepository
    {
        public List<AktualnostModel> GetAllAktualnosti()
        {
            List<AktualnostModel> data = new List<AktualnostModel>();

            
            data.Add(new AktualnostModel {
                Title = "Izložba Ivana Mažuranića - Kiparske inspiracije",
                ImageUrl = "img/Izbor_iz_zbirki_Galerije_umjetnina.jpg",
                Category = "IZLOŽBE",
                Location = "Galerija umjetnina",
                DateRange = "12.1.2018. - 12.2.2018."
            });

            data.Add(new AktualnostModel {
                Title = "Andy Warhol: The King of Pop Art",
                ImageUrl = "img/foto_Billy_Name_1529323525.jpg",
                Category = "PREDAVANJA",
                Location = "Kneževa palača",
                DateRange = "22.6.2018."
            });
            
            data.Add(new AktualnostModel {
                Title = "Razigrane žice",
                ImageUrl = "img/thumb_760_0x600_0_0_auto.jpg",
                Category = "KONCERTI",
                Location = "Kneževa palača",
                DateRange = "12.1.2018. - 12.2.2018."
            });
            
            data.Add(new AktualnostModel {
                Title = "Natječaj: 15 minutes of fame",
                ImageUrl = "img/oglas_15_minutes_1527238997.jpg",
                Category = "OSTALO",
                Location = "Kneževa palača",
                DateRange = "25.6.2018."
            });

            return data;
        }
    }
}

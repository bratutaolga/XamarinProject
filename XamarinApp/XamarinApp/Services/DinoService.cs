using XamarinApp.Business;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinApp.Services
{
    public class DinoService : IService<Dino>
    {
        IList<Dino> _dataList;
        string _folder = "Content/";

        public DinoService()
        {
            _dataList = new List<Dino>();
            _dataList.Add(new Dino { Id = 1, Name = "Аардоникс", Description = "Род растительноядных динозавров из подотряда завроподоморфов, живших в нижнем юрском периоде на территории нынешней ЮАР. Представлен единственным видом — Aardonyx celestae", ImagePath = _folder + "200px-Aardonyx_NT.jpg" });
            _dataList.Add(new Dino { Id = 2, Name = "Вулканодон", Description = "Вулканодон обладал небольшими размерами, в длину он составлял 6,5 метров, а в высоту был чуть больше человека, около 1,9 метра. Вес его был около 750 килограммов. Обладал длинными (относительно размеров тела) шеей и хвостом. Он был представителем травоядных ящеров, основным рационом которых были листья, трава и другая растительность, которую он заглатывал, так как зубы не были приспособлены для пережёвывания. Обитал вулканодон на территории современной Южной Африки (Зимбабве), около 208—201 млн лет назад (ранняя юра).", ImagePath = _folder + "200px-Trexsidec.jpg" });
            _dataList.Add(new Dino { Id = 3, Name = "Гигантозавр", Description = "Крупный плотоядный динозавр верхнемеловой эпохи из семейства кархародонтозаврид надсемейства аллозавроид.", ImagePath = _folder + "Giganotos_Db.jpg" });
            _dataList.Add(new Dino { Id = 4, Name = "Рапетозавр", Description = "Род динозавров-зауропод из клады Lithostrotia, живших во времена верхнемеловой эпохи на территории Мадагаскара. Ископаемые остатки были найдены во время экспедиции на остров Мадагаскар в 2004 году.", ImagePath = _folder + "Rapetosaurus_BW.jpg" });
            _dataList.Add(new Dino { Id = 5, Name = "Тиранозавр", Description = "Монотипический род плотоядных динозавров из группы целурозавров подотряда тероподов, включающий единственный валидный вид — Tyrannosaurus rex", ImagePath = _folder + "Triceratops_liveDB.jpg" });
            _dataList.Add(new Dino { Id = 6, Name = "Трицератопс", Description = "Род растительноядных динозавров из семейства цератопсид, существовали в конце маастрихтского века мелового периода и начале палеоценовой эпохи палеогенового периода, примерно от 68 до 66 миллионов лет назад на территориях современной Северной Америки", ImagePath = _folder + "Vulcanodon.jpg" });

        }
        public async Task<IList<Dino>> GetAll()
        {
            return _dataList;
        }
    }
}

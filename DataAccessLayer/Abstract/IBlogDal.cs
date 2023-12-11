using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        //Kategori ile birlikte listeyi getir
        List<Blog> GetListWithCategoryByWriter(int id);
        //Yazara göre kategori ile beraber getir
    }
}

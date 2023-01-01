using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal dal;

		public WriterManager(IWriterDal dal)
		{
			this.dal = dal;
		}

		public void WriterAdd(Writer writer)
		{
			 dal.Insert(writer);
		}
	}
}

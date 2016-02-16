﻿using System;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace GIAF.InfraStructure.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		[ThreadStatic]
		private static UnitOfWork _current;

		public DbContext Context { get; protected set; }

		public static UnitOfWork Current
		{
			get { return _current; }
			set { _current = value; }
		}

		private bool disposed = false;

		public UnitOfWork(DbContext ctx)
		{
			this.Context = ctx;
		}

		public void Commit()
		{
			Context.SaveChanges();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					Context.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}

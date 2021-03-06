﻿using System;
using System.Collections;
using System.Threading;

namespace CollegeBusiness.Util.DataContextStorage
{
  public class cThreadDataContextStorageContainer<T> : cIDataContextStorageContainer<T> where T : class
  {
    private static readonly Hashtable StoredContexts = new Hashtable();

    public T GetDataContext()
    {
      T context = null;

      if (StoredContexts.Contains(GetThreadName()))
      {
        context = (T)StoredContexts[GetThreadName()];
      }
      return context;
    }

    public void Clear()
    {
      if (StoredContexts.Contains(GetThreadName()))
      {
        StoredContexts[GetThreadName()] = null;
      }
    }

    public void Store(T objectContext)
    {
      if (StoredContexts.Contains(GetThreadName()))
      {
        StoredContexts[GetThreadName()] = objectContext;
      }
      else
      {
        StoredContexts.Add(GetThreadName(), objectContext);
      }
    }

    private static string GetThreadName()
    {
      if (string.IsNullOrEmpty(Thread.CurrentThread.Name))
      {
        Thread.CurrentThread.Name = Guid.NewGuid().ToString();
      }
      return Thread.CurrentThread.Name;
    }
  }
}
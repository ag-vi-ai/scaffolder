﻿using System;

namespace Scaffolder.Core.Meta
{
    public static class ObjectExtender
    {
        public static void MapExtendInformation(Table src, Table dst)
        {
            MapExtendInformation(src, (BaseObject)dst);

            if (src.Position != 0)
            {
                dst.Position = src.Position;
            }

            if (src.ShowInList != null)
            {
                dst.ShowInList = src.ShowInList;
            }
        }

        public static void MapExtendInformation(Column src, Column dst)
        {
            MapExtendInformation(src, (BaseObject)dst);

            if (src.Position != null)
            {
                dst.Position = src.Position;
            }

            if (src.IsKey != null)
            {
                dst.IsKey = src.IsKey;
            }

            if (src.Type != null)
            {
                dst.Type = src.Type;
            }

            if (src.IsNullable != null)
            {
                dst.IsNullable = src.IsNullable;
            }
           
            if (src.Readonly != null)
            {
                dst.Readonly = src.Readonly;
            }

            if (src.Reference != null)
            {
                dst.Reference = src.Reference;
            }

            if (src.ShowInGrid != null)
            {
                dst.ShowInGrid = src.ShowInGrid;
            }

            if (src.AutoIncrement != null)
            {
                dst.AutoIncrement = src.AutoIncrement;
            }

            if (src.MaxValue != null)
            {
                dst.MaxValue = src.MaxValue;
            }

            if (src.MinValue != null)
            {
                dst.MinValue = src.MinValue;
            }

            if (src.MaxLength != null)
            {
                dst.MaxLength = src.MaxLength;
            }

        }
        private static void MapExtendInformation(BaseObject src, BaseObject dst)
        {
            if (!String.IsNullOrEmpty(src.Title))
            {
                dst.Title = src.Title;
            }

            if (!String.IsNullOrEmpty(src.Description))
            {
                dst.Description = src.Description;
            }
        }
    }
}

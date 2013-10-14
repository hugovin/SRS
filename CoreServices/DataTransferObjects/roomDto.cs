//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace CoreServices.DataTransferObjects
{
    
    [DataContract(Name = "roomDto", Namespace = "" , IsReference = true) ]
    public partial class roomDto
    {
         #region Primitive Properties
    	
    	[DataMember]
        public virtual int room_id
        {
            get;
            set;
        }
    	
    	[DataMember]
        public virtual int building_id
        {
     
    		
            get { return _building_id; }
            set
            {
                if (_building_id != value)
                {
                    if (building != null && building.building_id != value)
                    {
                        building = null;
                    }
                    _building_id = value;
                }
            }
        }
        private int _building_id;
    	
    	[DataMember]
        public virtual Nullable<int> room_capacity
        {
            get;
            set;
        }
    	
    	[DataMember]
        public virtual string room_name
        {
            get;
            set;
        }
    	
    	[DataMember]
        public virtual string modified_by
        {
            get;
            set;
        }
    	
    	[DataMember]
        public virtual Nullable<System.DateTime> created_date
        {
            get;
            set;
        }
    	
    	[DataMember]
        public virtual Nullable<System.DateTime> modified_date
        {
            get;
            set;
        }
    	
    	[DataMember]
        public virtual Nullable<sbyte> is_active
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
    	[DataMember]
        public virtual buildingDto building
        {
            get { return _building; }
            set
            {
                if (!ReferenceEquals(_building, value))
                {
                    var previousValue = _building;
                    _building = value;
                    Fixupbuilding(previousValue);
                }
            }
        }
        private buildingDto _building;
    
    	[DataMember]
        public virtual ICollection<deviceDto> devices
        {
            get
            {
                if (_devices == null)
                {
                    var newCollection = new FixupCollection<deviceDto>();
                    newCollection.CollectionChanged += Fixupdevices;
                    _devices = newCollection;
                }
                return _devices;
            }
            set
            {
                if (!ReferenceEquals(_devices, value))
                {
                    var previousValue = _devices as FixupCollection<deviceDto>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupdevices;
                    }
                    _devices = value;
                    var newValue = value as FixupCollection<deviceDto>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupdevices;
                    }
                }
            }
        }
        private ICollection<deviceDto> _devices;
    
    	[DataMember]
        public virtual ICollection<reservationDto> reservations
        {
            get
            {
                if (_reservations == null)
                {
                    var newCollection = new FixupCollection<reservationDto>();
                    newCollection.CollectionChanged += Fixupreservations;
                    _reservations = newCollection;
                }
                return _reservations;
            }
            set
            {
                if (!ReferenceEquals(_reservations, value))
                {
                    var previousValue = _reservations as FixupCollection<reservationDto>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupreservations;
                    }
                    _reservations = value;
                    var newValue = value as FixupCollection<reservationDto>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupreservations;
                    }
                }
            }
        }
        private ICollection<reservationDto> _reservations;

        #endregion
        #region Association Fixup
    
        private void Fixupbuilding(buildingDto previousValue)
        {
            if (previousValue != null && previousValue.rooms.Contains(this))
            {
                previousValue.rooms.Remove(this);
            }
    
            if (building != null)
            {
                if (!building.rooms.Contains(this))
                {
                    building.rooms.Add(this);
                }
                if (building_id != building.building_id)
                {
                    building_id = building.building_id;
                }
            }
        }
    
        private void Fixupdevices(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (deviceDto item in e.NewItems)
                {
                    item.room = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (deviceDto item in e.OldItems)
                {
                    if (ReferenceEquals(item.room, this))
                    {
                        item.room = null;
                    }
                }
            }
        }
    
        private void Fixupreservations(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (reservationDto item in e.NewItems)
                {
                    item.room = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (reservationDto item in e.OldItems)
                {
                    if (ReferenceEquals(item.room, this))
                    {
                        item.room = null;
                    }
                }
            }
        }

        #endregion
    }
}

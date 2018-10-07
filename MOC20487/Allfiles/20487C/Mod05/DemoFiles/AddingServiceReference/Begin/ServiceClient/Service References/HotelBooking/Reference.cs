﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceClient.HotelBooking {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reservation", Namespace="http://schemas.datacontract.org/2004/07/HotelBooking")]
    [System.SerializableAttribute()]
    public partial class Reservation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CheckinDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GuestNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HotelNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberOfDaysField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CheckinDate {
            get {
                return this.CheckinDateField;
            }
            set {
                if ((this.CheckinDateField.Equals(value) != true)) {
                    this.CheckinDateField = value;
                    this.RaisePropertyChanged("CheckinDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GuestName {
            get {
                return this.GuestNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GuestNameField, value) != true)) {
                    this.GuestNameField = value;
                    this.RaisePropertyChanged("GuestName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HotelName {
            get {
                return this.HotelNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HotelNameField, value) != true)) {
                    this.HotelNameField = value;
                    this.RaisePropertyChanged("HotelName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumberOfDays {
            get {
                return this.NumberOfDaysField;
            }
            set {
                if ((this.NumberOfDaysField.Equals(value) != true)) {
                    this.NumberOfDaysField = value;
                    this.RaisePropertyChanged("NumberOfDays");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookingResponse", Namespace="http://schemas.datacontract.org/2004/07/HotelBooking")]
    [System.SerializableAttribute()]
    public partial class BookingResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BookingReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsApprovedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BookingReference {
            get {
                return this.BookingReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.BookingReferenceField, value) != true)) {
                    this.BookingReferenceField = value;
                    this.RaisePropertyChanged("BookingReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsApproved {
            get {
                return this.IsApprovedField;
            }
            set {
                if ((this.IsApprovedField.Equals(value) != true)) {
                    this.IsApprovedField = value;
                    this.RaisePropertyChanged("IsApproved");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HotelBooking.IHotelBookingService")]
    public interface IHotelBookingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelBookingService/BookHotel", ReplyAction="http://tempuri.org/IHotelBookingService/BookHotelResponse")]
        ServiceClient.HotelBooking.BookingResponse BookHotel(ServiceClient.HotelBooking.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelBookingService/BookHotel", ReplyAction="http://tempuri.org/IHotelBookingService/BookHotelResponse")]
        System.Threading.Tasks.Task<ServiceClient.HotelBooking.BookingResponse> BookHotelAsync(ServiceClient.HotelBooking.Reservation reservation);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHotelBookingServiceChannel : ServiceClient.HotelBooking.IHotelBookingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HotelBookingServiceClient : System.ServiceModel.ClientBase<ServiceClient.HotelBooking.IHotelBookingService>, ServiceClient.HotelBooking.IHotelBookingService {
        
        public HotelBookingServiceClient() {
        }
        
        public HotelBookingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelBookingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelBookingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelBookingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceClient.HotelBooking.BookingResponse BookHotel(ServiceClient.HotelBooking.Reservation reservation) {
            return base.Channel.BookHotel(reservation);
        }
        
        public System.Threading.Tasks.Task<ServiceClient.HotelBooking.BookingResponse> BookHotelAsync(ServiceClient.HotelBooking.Reservation reservation) {
            return base.Channel.BookHotelAsync(reservation);
        }
    }
}
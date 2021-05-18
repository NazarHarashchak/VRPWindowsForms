using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPWindowsForms.Models;
using VRPWindowsForms.Constant;

namespace VRPWindowsForms
{
    class SampleData
    {
        private readonly DatabaseContext context;
        public SampleData() { }
        public SampleData(DatabaseContext context)
        {
            this.context = context;
        }
        public void GetSample()
        {
            if (!context.OrderStatuses.Any())
            {
                context.OrderStatuses.AddRange(
                    new List<OrderStatus>() {
                        new OrderStatus()
                        {
                            ID = (int)OrderStatusesEnum.Created,
                            Status = "Created"
                        },
                        new OrderStatus()
                        {
                            ID = (int)OrderStatusesEnum.ReadyForDelivery,
                            Status = "Ready For Delivery"
                        },
                        new OrderStatus()
                        {
                            ID = (int)OrderStatusesEnum.OnMap,
                            Status = "On Map"
                        },
                        new OrderStatus()
                        {
                            ID = (int)OrderStatusesEnum.Active,
                            Status = "Active"
                        },
                        new OrderStatus()
                        {
                            ID = (int)OrderStatusesEnum.Closed,
                            Status = "Closed"
                        }
                    });

                context.SaveChanges();
            }
            if (!context.StoreTypes.Any())
            {
                context.StoreTypes.AddRange(new List<StoreType>() {
                    new StoreType()
                    {
                        ID = (int)StoreTypesEnum.FreightWarehouse,
                        Type = "Freight warehouse"
                    },
                    new StoreType()
                    {
                        ID = (int)StoreTypesEnum.DeliveryWarehouse,
                        Type = "Delivery warehouse"
                    }
                });
                context.SaveChanges();
            }
            if (!context.Customers.Any())
            {
                context.Customers.AddRange(new List<Customer>() {
                    new Customer()
                    {
                        Name = "Nazarii",
                        SecondName = "Harashchak",
                        Age = 21,
                        Email = "test1@gmail.com",
                        PhoneNumber = "+380999999999"
                    } ,
                    new Customer()
                    {
                        Name = "Victoria",
                        SecondName = "Harashchak",
                        Age = 21,
                        Email = "test2@gmail.com",
                        PhoneNumber = "+380999999999"
                    } ,
                    new Customer()
                    {
                        Name = "Dinara",
                        SecondName = "Mustafaieva",
                        Age = 21,
                        Email = "test3@gmail.com",
                        PhoneNumber = "+380999999999"
                    },
                    new Customer()
                    {
                        Name = "Ivan",
                        SecondName = "Korpan",
                        Age = 21,
                        Email = "test4@gmail.com",
                        PhoneNumber = "+380999999999"
                    }
                });
                context.SaveChanges();
            }
            if (!context.CarStatuses.Any())
            {
                context.CarStatuses.AddRange(new List<CarStatus>() { 
                    new CarStatus()
                    {
                        ID = (int)CarStatusesEnum.InStore,
                        Status = "In Store"
                    },
                    new CarStatus()
                    {
                        ID = (int)CarStatusesEnum.InDrive,
                        Status = "Delivering"
                    },
                    new CarStatus()
                    {
                        ID = (int)CarStatusesEnum.Inactive,
                        Status = "Inactive"
                    }
                });
                context.SaveChanges();
            }
        }
    }
}

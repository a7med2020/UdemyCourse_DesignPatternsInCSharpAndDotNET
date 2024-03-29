﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.BehavioralDesignPatterns._14Command.More
{

    public interface Order
    {
        void execute();
    }

    public class Stock
    {

        private String name = "ABC";
        private int quantity = 10;

        public void buy()
        {
            WriteLine(@"Stock [ Name: " + name + @", 
          
                   Quantity: " + quantity + " ] bought");
        }
        public void sell()
        {
            WriteLine(@"Stock [ Name: " + name + @", 
          
                   Quantity: " + quantity + " ] sold");
        }
    }

    public class BuyStock : Order
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.buy();
        }
    }

    public class SellStock : Order
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.sell();
        }
    }

    public class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void takeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void placeOrders()
        {

            foreach (Order order in orderList)
            {
                order.execute();
            }
            orderList.Clear();
        }
    }

    public class CommandPatternDemo
    {
        public static void main(String[] args)
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.takeOrder(buyStockOrder);
            broker.takeOrder(sellStockOrder);

            broker.placeOrders();
        }
    }

}

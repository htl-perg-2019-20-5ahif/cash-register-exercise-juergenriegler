# WPF Cash Register Sample

## Introduction

In this exercise, you create a simple cash register. The final result should be a user interface that looks like this:

![Cash Register](cash-register-main-window.png)

## Specification

* Create a backend Web API using ASP.NET Core and Entity Framework Core
* Create a frontend with WPF that uses the Web API backend.
* The database should store products. Every product consists of:
  * ID (numeric, unique key)
  * Product name (mandatory)
  * Unit price (numeric, mandatory)
* The database should store receipt lines. Every receipt line consists of:
  * ID (numeric, unique key)
  * Reference to the bought product
  * Amount of pieces bought
  * Total price (numeric, amount * product's unit price, calculated by backend)
* The database should store receipts. Every receipt consists of:
  * A list of receipt lines (at least one)
  * Receipt timestamp (auto-assigned by backend)
  * Total price (numeric, sum of total prices of all receipt lines, calculated by backend)


### (Source: https://github.com/rstropek/htl-csharp/blob/master/wpf/9020-register/readme.md)
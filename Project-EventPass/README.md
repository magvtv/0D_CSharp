# Event Ticketing Service
> This file is frequently updated, readers discretion is advised.  
- Trying to simulate this with C# and embracing object-oriented programming.
- Project to be developed in three phases in a span of one weeks
- 


## Project Breakdown

1. Designing with Classes

- Main entities of such a system would be: Events, Tickets, User, Venue of the Events, Payment Processing, Order.

- Events:
  Event title and description (the what, full details, performer)
  Date and the time (the when, use words instead of concrete time eg. evening, mid-morning, afternoon)
  Venue of the event (the where, google maps)
  User booking for the event (perhaps their gmail address, name)
  QR Code (showing validity of their order).

- Ticket:
  Event summary
  Optional seat number
  Price in KES
  Ticket status (available, reserved ["with partial payment to it"], sold out)

- User:
  Name
  Email (preferrably accessing with their gmail)
  Purchase History (for the fun of PH)

- Venue:
  Name
  Location
  Seating Layout (main reason for this)
  Capacity

- Payment:
  MPesa
  Automatically deduct from the user mpesa account
  Transaction ID
  See how Pi Consulting could include theirs perhaps

2. My Business Logic

Listing available events across Nairobi
Purchasing of tickets

﻿namespace api_cinema_challenge.DTO.Payloads
{
    public record CreateCustomerPayload(string Name, string Email, string Phone);
    public record UpdateCustomerPayload(string Name, string Email, string Phone);

    public record CreateMoviePayload(string Title, string Rating, string Description, int RuntimeMins);
    public record UpdateMoviePayload(string Title, string Rating, string Description, int RuntimeMins);

    public record CreateScreeningPayload(int ScreenNumber, int Capacity, DateTime StartsAt);
    public record CreateTicketPayload(int CustomerId, int ScreeningId, int NumSeats); //also added customer and screeningid, could maybe pass in customer_id and screening_id as params

}

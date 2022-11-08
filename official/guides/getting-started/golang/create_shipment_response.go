// Iterating through rates object printing out
// the carrier, service level, rate, and id
// of each possible rate.

rates := shipment.Rates
    for i := 0; i < len(rates); i++ {
        fmt.Println(rates[i].Carrier)
        fmt.Println(rates[i].Service)
        fmt.Println(rates[i].Rate)
        fmt.Println(rates[i].ID)
    }

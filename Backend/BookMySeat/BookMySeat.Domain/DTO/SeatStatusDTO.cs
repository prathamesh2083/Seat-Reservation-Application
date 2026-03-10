using BookMySeat.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMySeat.Domain.DTO;

public record SeatStatusDTO(int SeatId, int SeatNumber, Employee? BookedBy, int? BookingId);

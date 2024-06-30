import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StockService, Stock } from '../../services/stock.service';

@Component({
  selector: 'app-stock-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './stock-list.component.html',
  styleUrls: ['./stock-list.component.sass']
})
export class StockListComponent implements OnInit {
  stocks: Stock[] = [];

  constructor(private stockService: StockService) { }

  ngOnInit(): void {
    this.stockService.getStocks().subscribe(data => {
      this.stocks = data;
    });
  }
}

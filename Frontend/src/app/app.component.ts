import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { StockListComponent } from './components/stock-list/stock-list.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, StockListComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent {
  title = 'Frontend';
}

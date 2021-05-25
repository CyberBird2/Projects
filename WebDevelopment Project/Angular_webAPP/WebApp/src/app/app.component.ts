
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ThemeService } from './core/services/theme.service';
import { OverlayContainer } from '@angular/cdk/overlay';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Sigma Management';
  isDarkTheme: Observable<boolean>;

    constructor(private themeService: ThemeService,overlayContainer: OverlayContainer) {
      overlayContainer.getContainerElement().classList.add('dark-theme');
     }
  
    ngOnInit() {
      this.isDarkTheme = this.themeService.isDarkTheme;
    }

    
  
}


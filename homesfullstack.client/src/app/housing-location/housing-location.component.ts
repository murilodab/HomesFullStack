import { Component, Input } from '@angular/core';
import { HousingLocation } from '../housinglocation';

@Component({
  selector: 'app-housing-location',
  templateUrl: './housing-location.component.html',
  styleUrl: './housing-location.component.css'
})
export class HousingLocationComponent {
  @Input() housingLocation!: HousingLocation;

  getDefaultImage(): string {
    return 'assets/placeholder-image.jpg';
  }
}

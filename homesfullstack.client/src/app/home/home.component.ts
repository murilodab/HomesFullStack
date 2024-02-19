import { Component, OnInit, inject } from '@angular/core';
import { HousingLocation } from '../housinglocation';
import { HousingService } from '../housing.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {

  houses: HousingLocation[] = [];

  constructor(private housingService: HousingService) { }

  ngOnInit(): void {
    this.getHousingLocations();
  }

  getHousingLocations(): void {
    this.housingService.getAllHousingLocations().subscribe(houses => this.houses = houses.slice(1, 5));
  }

  //filterResults(text: string) {
  //  if (!text) {
  //    this.filteredLocationList = this.housingLocationList;
  //    return;
  //  }

  //  this.filteredLocationList = this.housingLocationList.filter(
  //    (housingLocation) =>
  //      housingLocation?.city.toLowerCase().includes(text.toLowerCase()) //Filter by City
  //  );

}


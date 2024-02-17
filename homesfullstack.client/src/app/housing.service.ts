import { Injectable } from '@angular/core';
import { HousingLocation } from './housinglocation'

@Injectable({
  providedIn: 'root'
})
export class HousingService {

  url = 'http://localhost:5149/Homes'

  async getAllHousingLocations(): Promise<HousingLocation[]> {
    const data = await fetch(this.url);
    return await data.json() ?? [];
  }

  constructor() { }
}

import { Component, Input } from '@angular/core';
import { Test } from '../models/test.model';

@Component({
  selector: 'app-test-list',
  templateUrl: './test-list.component.html',
  styleUrls: ['./test-list.component.scss']
})
export class TestListComponent {
  @Input()
  Tests: Test[];
  
}

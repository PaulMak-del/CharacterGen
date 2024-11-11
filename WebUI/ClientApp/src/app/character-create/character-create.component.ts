import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
    selector: 'app-character-create',
    standalone: true,
    imports: [NgFor],
    templateUrl: './character-create.component.html',
    styleUrl: './character-create.component.css'
})
export class CharacterCreateComponent {

    protected moralPositions = ['test1', 'test2', 'test3'];
    protected backgrounds = ['test1', 'test2', 'test3'];
    protected skills = ['test1', 'test2', 'test3'];

    protected generateRandomValues() {
    }
}

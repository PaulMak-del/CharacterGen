import { AfterViewInit, Component } from '@angular/core';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-generation',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './generation.component.html',
  styleUrls: ['./generation.component.css'],
})
export class GenerationComponent implements AfterViewInit {

    imageSrc: string | undefined;

    // Переменные для выпадающих списков
    races: string[] = ['Человек', 'Эльф', 'Гном', 'Орк'];
    genders: string[] = ['Мужской', 'Женский'];
    classes: string[] = ['Воин', 'Маг', 'Лучник', 'Вор'];

    constructor() {}

    public ngAfterViewInit(): void {
        const form = document.getElementById('character-form') as HTMLFormElement;
        form?.addEventListener('submit', (event) => {
            event.preventDefault(); // Предотвращаем стандартное поведение формы

            const race = (document.getElementById('race') as HTMLInputElement).value;
            const gender = (document.getElementById('gender') as HTMLInputElement).value;
            const className = (document.getElementById('class') as HTMLInputElement).value;

            // Здесь можно добавить логику генерации результата
            const resultPreview = document.getElementById('result-preview');
            if (resultPreview != null) {
                resultPreview.innerHTML = `<p>Сгенерированный персонаж: ${race}, ${gender}, ${className}</p>`;
            }
        });
    }

    public previewImage(event: Event) {
        const file = (event.target as HTMLInputElement).files?.[0];
        const reader = new FileReader();

        console.log(file);

        reader.onload = (e) => {
            this.imageSrc = reader.result as string;
        };

        if (file) {
            reader.readAsDataURL(file);
        }
    }
}

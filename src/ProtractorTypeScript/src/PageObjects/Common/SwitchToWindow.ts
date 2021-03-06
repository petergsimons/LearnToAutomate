import { browser } from 'protractor';

export class SwitchTo {

    /**
     *
     * @param index - the index is 0 based so the first tab will be index:0
     */
    public static async browserWindow(index:number): Promise<void> {
        const windows = await browser.getAllWindowHandles();
        console.info('windows: ', windows);

        if (index < windows.length) {
            console.info('switching to ', windows[index]);
            await browser.switchTo().window(windows[index]);
        } else {
            throw new Error(`Tab at index ${index} does not exist. There are only ${windows.length} tabs.`);
        }
    }
}

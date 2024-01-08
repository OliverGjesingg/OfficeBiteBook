import Link from 'next/link'

export default async function MenuButton() {

  return(
    <Link
      href="./"
      className="py-2 px-3 flex rounded-md no-underline"
    >
      menu
    </Link>
  )
}
